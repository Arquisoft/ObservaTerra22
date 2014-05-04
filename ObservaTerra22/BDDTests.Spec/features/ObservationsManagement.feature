Feature: Observation management

Scenario: Calculate the mean of observations about a specific area, like Europe, for a given indicator
	Given a collection of observations about a specific indicator:
	| Country	|	Value	|
	|	Spain	|	1.5	|
	|	France	|	1.5	|
	|	Italy	|	3	|
	|	China	|	1	|
	When the system obtains the mean of such indicator
	Then the result must be equal to 2

Scenario: Get the observations stored in the system about a given area or indicator
	Given an empty collection of observations the system has stored about a given area or indicator
	When a request asking for that information arrives at the system
	Then the system will notify the user that it has no information, so the result is empty

Scenario: A new observation about a given aspect in Europe is added to the system
	Given a list of indicators about a specific issue:
	|	Country	| Number of observations	|
	|	Spain	|	15	|
	|	France	|	25	|
	|	Italy	|	31	|
	|	China	|	13	|
	And a new observation about that issue in China is added
	When the system is asked for observations about that issue in China
	Then the result sent back to the user will be formed by those 14 observations stored in the system