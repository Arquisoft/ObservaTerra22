Feature: System register process

Scenario: A user completes successfully the register process
	Given a user not logged in the system
	When such user sends a register request to the system
	And completes successfully the register form with no errors
	Then a new account is created for such user

Scenario: A user does not complete successfully the register process
	Given a user not logged in the system
	When such user sends a register request to the system
	And the ident the user is trying to use is already registered in the system
	Then the system will notify the user of such conflict and no new account will be created