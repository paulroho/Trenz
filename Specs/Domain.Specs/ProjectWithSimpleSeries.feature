Feature: Projecting future Amounts

Scenario: Project with simple series

Given a Track "Breakfasts" with
	| Model | One each day      |
	| Seed  | 123bf @2018-01-01 |
  And a model "One each day" with a single series "each day +1"

When I ask for the Amount of the Track "Breakfasts" from 2018-01-01 to 2018-01-04 I get
	| Sample                     |
	| 123bf @2018-01-01 00:00:00 |
	| 124bf @2018-01-02 00:00:00 |
	| 125bf @2018-01-03 00:00:00 |
	| 126bf @2018-01-04 00:00:00 |
