# Testing

### Sprint 03
| Test | Result |
|------|--------|
| Create election stopped if title, candidates, or electorate fields not present | pass |
| Electorate file rejected if incorrect format | fail |
| Election can be created in database | pass |
| Voting prevented if no candidate selected | pass |
| Results pie chart is generated with proper scaling | pass |

### Sprint 04
| Test | Result |
|------|--------|
| ResultCard drop-down functioning correctly | pass |
| Multiple election results are viewable | pass |

### Sprint 05
| Test | Result |
|------|--------|
| Election Management page reads election data properly from db | pass |
| Spinner shows while election is being created | pass |
| Election management buttons disabled while election is being created | pass |
| User's created elections appear on Election Management page | pass |
| Badge displays appropriate message depending on election start date | pass |
| Voting page reads election data properly from db | pass |
| Voting page displays only elections user is a part of | pass |
| Voting page displays only active elections | pass |
| Results pie charts are displayed in the correct locations | pass |

### Sprint 06
| Test | Result |
|------|--------|
| User cannot vote twice on the same election | pass |
| Election results are accurate as per the db | pass |
| Results chart not displayed when election had no votes | pass |
| Results badge indicates if there was a winner, a tie, or no votes | pass |
| User can only view results pertinent to them | pass |
| Home page alert displays soonest ending election for user | pass |
| Home page alert accounts for elections the user has already voted in | fail |

### Sprint 07
| Test | Result |
|------|--------|
| Functionality remains after API changes/server function reorganizing | pass |
| Front page alert displays only if user has elections they haven't voted in | pass |
| Front page alert HTTP request is only made when a user is logged in | pass |
| Emails are sent to the electorate on election creation | fail |
| Emails are sent only if the checkbox was checked | fail |
| Voting page UI scales with window size | pass |

### Sprint 08
| Test | Result |
|------|--------|
| User can manually close active elections | pass |
| User can hide concluded elections | pass |
| Voting page displays content even if user has no active elections | pass |
| Emails are sent to the electorate on election creation | fail |
| Emails are sent only if the checkbox was checked | fail |
| Election mangement UI scales to fit window | fail |
| Data annotations on election creation form work with Bootstrap styling | pass |

### Sprint 09
| Test | Result |
|------|--------|
| Emails are sent to the electorate on election creation | pass |
| Emails are sent only if the checkbox was checked | pass |
| Election mangement UI scales to fit window | pass |
| Voter can be added to existing election | pass |
| Voter is not added if they are already in the electorate | pass |
| Voter is not added if basic email regex fails | pass |
| Gmail password not viewable on GitLab | fail |

### Sprint 10
| Electorate file is rejected if it does not contain the "Email" field | pass |
| Empty candidates are not added | pass |
| Whitespace is trimmed from candidate names | pass |
| UI scales uniformly on larger displays | true |
| Gmail password not viewable on GitLab | fail |
| Email notification contains more detail | fail |
| App logo is displayed properly | pass |

### Sprint 11
| New voter is sent email notification only if checkbox is checked | pass |
| Election title appears in email notification | pass |

### Sprint 12
| Election creator appears in email notification | pass |
| App logo appears in email notification | pass |
