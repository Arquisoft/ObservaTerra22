Feature: Information resources

Scenario: Documents request
	Given a collection of public documents about some subjects
		| Subject          | Number of public documents |
		| Hunger        | 164                             |
		| Pollution | 49                              |
		| Poverty       | 143                             |
		| Education     | 138                             |
	When the user asks for documents about hunger
	Then the system will respond to such request with the 164 documents related to hunger

Scenario: Guest user asks for private resources
	Given a collection of resources about a given subject:
		| Availability | Units |
		| Public         | 12       |
		| Private         | 9        |
	When a guest user asks for information about that subject
	Then the system will respond with the 12 public documents about that subject

Scenario: Request with no results due to privileges
	Given a collection of resources about a given subject
	When a user asks for information about that given subject, but has no privileges to access any of the documents related to the subject
	Then no document will be sent back to the user

Scenario: Guest user adds resource
	Given a collection of n resources about a given subject
	When a guest user tries to add a new resource about that subject
	Then the request will be denied and the collection of resources will have n elements still
	
Scenario: Registered user adds new resource
	Given a collection of n resources about a given subject
	When a registered user tries to add a new resource about that subject
	Then the request will be accepted and the collection of resources will have n+1 elements

Scenario: Request for resources in different language
	Given a given resource stored in a given language
	When a request for that resource in a different language arrives
	Then the system will show the resource in the language the user asked for

Scenario: Origin of resource
	Given a resource stored in the system
	When a registered user asks for the source of a given resource
	Then the system will shoe the source of the resource, that must be an organiization or another registered user, but never an unknown value