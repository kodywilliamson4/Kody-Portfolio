def function1
    puts "Input three lines of text: "
    input1 = gets
    input2 = gets
    input3 = gets
    aFile = File.new("savedLines.txt","w")
    aFile.write(input1)
    aFile.write(input2)
    aFile.write(input3)
end
def function2
    puts "Input the name of a file: "
    fileName = gets
    x = /CPlusPlus|Python/
    y = /Scala|Ruby/
    if fileName =~ x
    	puts "The file is important"
    end
    if fileName =~ y
    	puts "The file is extraordinary"
    end
    if !(fileName =~ x ) and !(fileName =~y)
    	puts "The file is unknown"
    end
end
def function3
    a = 1
    b = 0
    until a > 50 do
    	b = a * a * a
    	puts("The cube of integer #{a} is #{b}")
    	a = a + 1
    end
end
def function4
    flips = 0
    a = []
    count = 1
    heads = 0
    tails = 0
    while (flips < 10) or (flips > 200) do
    	puts "How many times do you want to flip the coin between 10 and 200"
    	flips = gets.chomp.to_i
    end
    if (flips < 10) or (flips > 200)
    	puts "Please input an integer in the specified range"
    end
    if !(flips < 10) and !(flips > 200)
    	until count > flips do
    	    num = rand(2)
    	    a.push(num)
    	    count = count + 1
    	end
    	count = 1
    	until count > flips do
    	    if a[count - 1] == 1
    	    	heads = heads + 1
    	    end
    	    if a[count - 1] == 0
    	        tails = tails + 1
    	    end
    	    count = count + 1;
    	end
    	puts("The ratio of heads to tails is #{heads} to #{tails}")
    end
    
end
def function5
    aFile = File.new("story.txt", "r")
    wordCount = 0
    distinct = 0
    mostWord = "test"
    mostCount = 0
    secondWord = "test"
    secondCount = 0
    sCount = 0
    words = []
    freq = Hash.new(0)
    aFile.each do |line|
    	words = line.split
    	words.each do |word|
    	    if freq.has_key?(word)
    	    	freq[word] = freq[word] + 1
    	    	wordCount = wordCount + 1
    	    end
    	    if !(freq.has_key?(word))
    	    	freq[word] = 1
    	    	wordCount = wordCount + 1
    	    	distinct = distinct + 1
    	    end
    	end
    end
    freq.each do |key, value|
    	if value > mostCount
    	    secondWord = mostWord
    	    secondCount = mostCount
    	    mostCount = value
    	    mostWord = key
    	end
    	if key.start_with?("s")
    	    sCount = sCount + 1
    	end
    end
    puts ("The number of words in the story is: #{wordCount}")
    puts ("The number of distinct words in the story is: #{distinct}")
    puts ("The second most frequest word is #{secondWord} which appears #{secondCount} times.")
    puts ("The number of words that start with s: #{sCount}")
    	    
end
# Now call the functions as the following.
function1
function2
function3
function4
function5

