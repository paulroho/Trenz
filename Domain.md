# The Domain

## Amount
E.g. 123€, 123cm, 78kg, 10 squats, 12 people 

Consists of
- Value (e.g. 94,568 - decimal)
- Unit (e.g. kg, m, €, squats)


## Change
A [Change](#change) is a delta of an [Amount](#amount) at a given point in time. It can be positive or negative.

Defined by
- Point in time
- [Amount](#amount)

E.g. 34,56€ @12.9.2017 12:28:12

   
## Track (of Changes)
[Amount](#amount) over time

- Consists of all [Changes](#change) to an [Amount](#amount).
- Allows to get the [Amount](#amount) at any point in time.
- Changes over time can be predicted according to a [Model](#model).

Defined by
- Name
- [Model](#model)

E.g. Monthly Income, Payments for child care, number of situps made, kilometres run, waist circumfere, ...


## Sample
Sample of the [Amount](#amount) of a [Track](#track) at a given point in time

Consists of
- Point in time
- [Amount](#amount) at that point in time

   
## Model
Describes the [Changes](#change) in a [Track](#track).

A Model consists of a number of [Series](#series).


## Series
A series of [Changes](#change), typically based on some [Rule](#rule) depending on time.

Defined by
- a Name
- a Rule

E.g. monthly payments, planned minutes of excercise per day


## Rule
Defines the collection of [Changes](#change) in a [Time Span](#timespan).

E.g. +1 squat each day, 1.234,56€ on the 15th of each month (or the following Monday in case of a weekend)


## Time Span
A concrete span of time with defined begin and end.

By definition both ends of the time span are included within the time span.

Defined by
- Start (point in time)
- End (point in time)

E.g. 1.1.2018 0:00 - 1.2.2018 0:00, 23.5.2017 12:30-16:00