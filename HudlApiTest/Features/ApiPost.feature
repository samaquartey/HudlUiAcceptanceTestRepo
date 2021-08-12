Feature: ApiPost
	

Scenario: 01. Create opponent information with valid details
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully

#Negative
@negative
Scenario: 02. Create opponent information with invalid game Id
	Given create opponent information with table details
	| gameId | sqlId   | date                | opponent     | opponentId | gameType |
	| NNNNNN | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then api post to create opponent information should error

Scenario: 03. Create opponent information with invalid sql Id
	Given create opponent information with table details
	| gameId  | sqlId | date                | opponent     | opponentId | gameType |
	| 1234567 | OOOOO | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then api post to create opponent information should error

Scenario: 04. Create opponent information with invalid opponentId Id
	Given create opponent information with table details
	| gameId  | sqlId | date                | opponent     | opponentId | gameType |
	| 1234567 | OOOOO | 2016-01-01T19:00:00 | TestOpponent | 00000222   | 0        |
	Then api post to create opponent information should error

Scenario: 05. Create opponent information with invalid opponentId Id
	Given create opponent information with table details
	| gameId  | sqlId | date                | opponent     | opponentId | gameType |
	| 1234567 | OOOOO | 2016-01-01T19:00:00 | TestOpponent | 00000222   | 0        |
	Then api post to create opponent information should error