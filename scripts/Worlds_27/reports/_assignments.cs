#include "../lib/_assigned_stage.cs"
#include "../lib/_constants.cs"

Define("DoAssignmentReportForOneTeam",
       AssignmentReport(
         Persons((NumberProperty(STAFF_TEAM) == {2, Number})),
         Filter(
           Flatten(
             Map({1, Array<Round>}, Groups())),
           (Stage() == AssignedStageForTeam({2, Number}, Date(StartTime(Arg<Group>()))))), {3, String}))

Define("DoAssignmentReport",
       Map([1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
           DoAssignmentReportForOneTeam({1, Array<Round>}, Arg<Number>(), {2, String})))