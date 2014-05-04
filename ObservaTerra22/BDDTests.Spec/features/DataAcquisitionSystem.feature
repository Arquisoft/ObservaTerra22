Feature: External data acquisition system

Scenario: Add new external data acquisition systems
	Given a new data acquisition system that is added to the system, no matter its programming language
	When all the data acquisition elements are executed
	Then this new acquisition system will be executed too, and its results will be processed as well
	And the main system won't stop executing at any moment

Scenario: The data acquisition elements are executed
	Given a list of external data sources the system is subscribed to
	When the data acquisition elements are executed
	Then all the external data sources that the system is subscribed to will be analyzed, and their results will be processed