Feature: System access

Scenario: A registered user logs in
	Given a user already registered in the system
	When such user logs in the system
	Then the system assigns him/her a token for the session, along with the groups the user belongs to, that grants him/her access

Scenario: A user not registered in the system logs in
	Given a user not registered in the system
	When such user logs in the system
	Then the system denies the login request

Scenario: A user accesses the system without logging in
	Given a user not logged in
	When the user accesses the system
	Then the system assigns such user a default token that identifies him/her as a guest user