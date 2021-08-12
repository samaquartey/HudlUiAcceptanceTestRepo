Feature: ApiDelete
	

Scenario: 01. Delete opponent information for game id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I delete opponent information for game Id "1234567"
	Then opponent information for game id "1234567" is no longer available


Scenario: 02. Delete opponent information for invalid game id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I delete opponent information for game Id "OOoppp"
	Then delete api request should fail with error