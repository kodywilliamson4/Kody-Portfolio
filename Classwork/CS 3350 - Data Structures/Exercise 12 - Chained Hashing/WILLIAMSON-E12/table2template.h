// FILE: table2template.h
// TEMPLATE CLASS IMPLEMENTED: table (see table2.h for documentation)
// INVARIANT for the table ADT:
//   1. The number of records in the table is in the member variable total_records.

#include <cassert>  // Provides assert
#include <cstdlib>  // Provides size_t
#include <iostream>

namespace main_savitch_12B
{
    template <class RecordType>
    table<RecordType>::table( )
    {
        std::size_t i;

        total_records = 0;
        for (i = 0; i < TABLE_SIZE; ++i)
        {
            data[i] = NULL;
            bucket_size[i] = 0;
        }
        
        metrics.tot_calls = 0;
        metrics.tot_comps = 0;
        metrics.min_comps = 2;
        metrics.max_comps = 0;
    }

    template <class RecordType>
    void table<RecordType>::copy(const table<RecordType> & source)
    {
        std::size_t i;
        main_savitch_6B::node<RecordType>* temp;

        total_records = source.total_records;
        for (i = 0; i < TABLE_SIZE; ++i)
        {
            list_copy (source.data[i], data[i], temp);
            bucket_size[i] = source.bucket_size[i];
        }

        // Start stats afresh
        metrics.tot_calls = 0;
        metrics.tot_comps = 0;
        metrics.min_comps = 2;
        metrics.max_comps = 0;
    }

    template <class RecordType>
    table<RecordType>::table(const table<RecordType> & source)
    {
        copy (source);
    }

    template <class RecordType>
    void table<RecordType>::free()
    {
        for (std::size_t i = 0; i < TABLE_SIZE; ++i)
            if (data[i]!=NULL) list_clear (data[i]);
    }

    template <class RecordType>
    table<RecordType>::~table()
    {
        free();
    }

    template <class RecordType>
    void table<RecordType>::operator =(const table<RecordType>& source)
    {
        if (this != &source)
        {
            free ();
            copy (source);
        };
        // No return (*this); because we chose not to do chaining (return type is void)
    }

    template <class RecordType>
    inline std::size_t table<RecordType>::hash(int key) const
    {
        return (key % TABLE_SIZE);
    }

    template <class RecordType>
    void table<RecordType>::insert(const RecordType& entry)
    // Library facilities used: cassert
    {
        std::size_t index;
        bool already_present;   // True if entry.key is already in the table
        RecordType result;

        assert(entry.key >= 0);

        find(entry.key, already_present, result);

        // If the key wasn't already there, then find the location for the new entry.
        if (already_present) result = entry;
        else
        {
            index = hash(entry.key);
            list_head_insert(data[index], entry);
            bucket_size[index] += 1;
            ++total_records;
        }
    }

    template <class RecordType>
    void table<RecordType>::remove(int key)
    // Library facilities used: cassert
    {
        std::size_t index = hash(key);
        main_savitch_6B::node<RecordType> *cursor, *prev;
        prev = nullptr;

        assert(key >= 0);

        // Look for the record with the given key.
        // If key is NOT present, there is nothing to remove,
        // BUT the metrics/stats still should be updated!
        // If key is present, first remove the record, and also
        // make sure to update the metrics/stats.
        // You will NOT be able to use the find method DIRECTLY,
        // because it doesn't give you all the details you would
        // need to actually remove the node!  However, you may
        // certainly start with the logic from find and modify it.
        // To get you started, index has been initialized to the
        // bucket's/chain's index, which would contain the key if present.

        // ************** EDIT HERE **************
        std::size_t count = 0;
        for (cursor = data[index]; cursor != NULL; (cursor = cursor->link()) && (prev = cursor))
        {
            if (++count && (key == cursor->data().key))
            {
                if (prev = NULL)
                {
                    list_head_remove(cursor);
                    bucket_size[index] -= 1;
                    --total_records;
                    break;
                }
                else
                {
                    list_remove(prev);
                    bucket_size[index] -= 1;
                    --total_records;
                    break;
                }
            }
        }

        metrics.tot_calls++;
        metrics.tot_comps += count;
        if (count < metrics.min_comps) metrics.min_comps = count;
        if (count > metrics.max_comps) metrics.max_comps = count;
    }

    template <class RecordType>
    bool table<RecordType>::is_present(int key)
    // Library facilities used: assert.h
    {
        bool found;
        RecordType ignore;

        assert(key >= 0);

        find(key, found, ignore);
        return found;
    }

    template <class RecordType>
    void table<RecordType>::find(int key, bool& found, RecordType& result)
    // Library facilities used: cassert.h
    {
        std::size_t index = hash(key);
        main_savitch_6B::node<RecordType>* cursor;
        std::size_t count = 0;

        found = false;

        assert(key >= 0);

        for (cursor = data[index]; cursor!=NULL; cursor=cursor->link())
            if (++count && (key == cursor->data().key))
            {
                found = true;
                result = cursor->data();
                break;
            }

    // update metrics/stats
    metrics.tot_calls++;
    metrics.tot_comps += count;
    if (count < metrics.min_comps) metrics.min_comps = count;
    if (count > metrics.max_comps) metrics.max_comps = count;
    }

    template <class RecordType>
    void table<RecordType>::stats () const
    {
        std::cout << "Minimum number of comparisons = " << metrics.min_comps << std::endl;
        std::cout << "Maximum number of comparisons = " << metrics.max_comps << std::endl;
        std::cout << "Average number of comparisons = " << float(metrics.tot_comps)/metrics.tot_calls << std::endl;
        std::cout << "Total number of times searched = " << metrics.tot_calls << std::endl;

        size_t max_bs = 0;
        size_t min_bs = total_records;
        for (size_t i = 0; i<TABLE_SIZE; i++)
        {
            if (max_bs < bucket_size[i]) max_bs = bucket_size[i];
            if (min_bs > bucket_size[i]) min_bs = bucket_size[i];
        };
        std::cout << "Size of the largest bucket = " << max_bs << std::endl;
        std::cout << "Size of the smallest bucket = " << min_bs << std::endl;

//        for (int i =0; i<CAPACITY; i++) std::cout<<data[i].key<<std::endl;
    }
}
