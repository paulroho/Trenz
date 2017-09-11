Feature: Projecting future Amounts

Scenario: Project with simple series

Given a Track "Breakfasts" with
	| Model | One each day  |
	| Seed  | 0bf @1/1/2018 |
  And a model "One each day" with a single series "each day +1"

When I ask for the Amount of the Track "Breakfasts" from 1/1/2018 to 1/4/2018 I get
	| Sample                    |
	| 0bf @1/1/2018 12:00:00 AM |
	| 1bf @1/2/2018 12:00:00 AM |
	| 2bf @1/3/2018 12:00:00 AM |
	| 3bf @1/4/2018 12:00:00 AM |
