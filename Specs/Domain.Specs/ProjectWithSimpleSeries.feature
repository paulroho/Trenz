Feature: Projecting future Amounts

Scenario: Project with simple series

Given a Track "Breakfasts" with
	| Model | One each day  |
	| Seed  | 0bf @1/1/2018 |
  And a model "One each day" with a single series "each day +1"

When I ask for the Amount of the Track "Breakfasts" from 1/1/2018 to 1/4/2018 I get
	| Sample                   |
	| 0bf @01/01/2018 00:00:00 |
	| 1bf @01/02/2018 00:00:00 |
	| 2bf @01/03/2018 00:00:00 |
	| 3bf @01/04/2018 00:00:00 |
