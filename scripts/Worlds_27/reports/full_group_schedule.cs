#include "../lib/_constants.cs"

Map(
    [2027-07-22, 2027-07-23, 2027-07-24, 2027-07-25],
    NoPageBreak(All(
        Header(Weekday(Arg<Date>())),
        Table(
            Sort(
                AllGroups(),
                StartTime()),
            [Column("Group", GroupName()),
            Column("Start", FormatTime(StartTime()))]))))