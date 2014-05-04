Feature: External data sources

Scenario: Obtain publications of external data sources
	Given a collection of stored resources in the system about a given subject in a given area
	And a data source the system ObservaTerra is subscribed to has published a new resource about that subject in that area
	When the main system runs the external data acquisition system next time
	Then the collection of resources about that subject in that area will be one unit greater

Scenario: Add a new external data source to the list of subscriptions
	Given a collection of external data sources ObservaTerra is subscribed to
	When the administrator subscribes the system to a new external data source
	Then the collection of external data sources subscribed to will be one unit greater

Scenario: Delete a data source from the subscription collection
	Given a collection of external data sources the system is subscribed to
	When the administrator removes one of the subscriptions from that collection
	Then the collection of subscriptions will be one unit smaller

Scenario: Data acquisition after removal
	Given a collection of external data sources the system is subscribed to
	When the administrator removes one of the subscriptions from that collection
	Then the next time the external data acquisition system is executed, none of the crawlers will analyze the data source that was just deleted from the collection