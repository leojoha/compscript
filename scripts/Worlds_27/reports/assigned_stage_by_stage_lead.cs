#include "../lib/_assigned_stage.cs"
#include "../lib/_constants.cs"

Table(
  Sort(Persons(BooleanProperty(STAGE_LEAD)), NumberProperty(STAFF_TEAM)),
  Concat([Column("Name", Name())],
         Map([2027-07-22, 2027-07-23, 2027-07-24, 2027-07-25],
             Column(Weekday(Arg<Date>()), AssignedStage(Arg<Person>(), Arg<Date>())))))