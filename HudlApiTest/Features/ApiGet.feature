Feature: ApiGet


Scenario: 01. Get opponent information with opponent name
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	Given I get list of opponent information for "TestOpponent"
	Then opponent data in response has opponent Id "123456"


Scenario: 02. Get opponent information with opponent Id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	Given I get list of opponent information for "123456"
	Then opponent data in response has opponent Id "123456"


Scenario: 03. Get opponent information with opponent & opponent Id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	Given I get list of opponent information for opponent "TestOpponent" & opponent id "123456"
	Then opponent data in response has opponent "TestOpponent" & opponent Id "123456"

#Negative
@negative
Scenario: 04. Get opponent information with invalid opponent name
	Given I get list of opponent information for "123456"
	Then api get call failed with error


Scenario: 05. Get opponent information with invalid opponent id
	Given I get list of opponent information for "123456"
	Then api get call failed with error