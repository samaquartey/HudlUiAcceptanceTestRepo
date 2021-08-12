Feature: ApiPut
	
#Note in this case all other info should still remain same
Scenario: 01. Update opponent game id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 7654321 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data in response has new game Id "7654321"

Scenario: 02. Update opponent sql id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 7654321 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data in response has new sql Id "7654321"

Scenario: 03. Update opponent id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 7654321 | 2016-01-01T19:00:00 | TestOpponent | 654321     | 0        |
	Then opponent data in response has new sql Id "654321"

Scenario: 04. Update opponent
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent        | opponentId | gameType |
	| 1234567 | 7654321 | 2016-01-01T19:00:00 | TestOpponentAbc | 654321     | 0        |
	Then opponent data in response has new opponent "TestOpponentAbc"


#Negative
Scenario: 05. Update opponent game id - invalid game id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 7654321 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data update should fail with error

Scenario: 06. Update opponent sql id - invalid sql id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId    | date                | opponent     | opponentId | gameType |
	| 1234567 | abcdefgh | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data update should fail with error

Scenario: 07. Update opponent id - invalid opponent id
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 7654321 | 2016-01-01T19:00:00 | TestOpponent | qwertvvf   | 0        |
	Then opponent data update should fail with error

Scenario: 08. Update opponent - invalid opponent
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId  | sqlId   | date                | opponent | opponentId | gameType |
	| 1234567 | 7654321 | 2016-01-01T19:00:00 | 111111   | 654321     | 0        |
	Then opponent data update should fail with error

Scenario: 09. Update all details with - invalid infomation
	Given create opponent information with table details
	| gameId  | sqlId   | date                | opponent     | opponentId | gameType |
	| 1234567 | 1234567 | 2016-01-01T19:00:00 | TestOpponent | 123456     | 0        |
	Then opponent data is created successfully
	When I update opponent information
	| gameId | sqlId   | date      | opponent | opponentId | gameType |
	| 000000 | acvewsl | ggee01T19 | demodemo | pppcees    | 0        |
	Then opponent data update should fail with error