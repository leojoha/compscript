#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

# Change persons and board meetings

Define("FMC1Overlap", And((EndTime() > 2027-07-23T10:20), (StartTime() < 2027-07-23T09:00)))
Define("FMC23Overlap", And((EndTime() > 2027-07-23T15:20), (StartTime() < 2027-07-23T12:50)))

AssignGroups(_222-r1,
             RoundOneAssignmentSets(_222, 2027-07-23),
             Concat(DefaultScorers(2027-07-23, _222),
                    [ByFilters(Or(CompetingIn(_333fm),
                                  StaffingFridayFMC(Arg<Person>())), FMC1Overlap(Arg<Group>()), -20)]))

AssignGroups(_444-r1,
             RoundOneAssignmentSets(_444, 2027-07-23),
             Concat(DefaultScorers(2027-07-23, _444),
                    [ByFilters(Or(CompetingIn(_333fm),
                                  StaffingFridayFMC(Arg<Person>())), FMC23Overlap(Arg<Group>()), -20)]))

AssignGroups(_sq1-r1,
             RoundOneAssignmentSets(_sq1, 2027-07-23),
             Concat(DefaultScorers(2027-07-23, _sq1),
             [ByFilters(Or(CompetingIn(_333fm),
                                  StaffingFridayFMC(Arg<Person>())), FMC23Overlap(Arg<Group>()), -20)]))

AssignGroups(_666-r1,
             RoundOneAssignmentSets(_666, 2027-07-23),
             DefaultScorers(2027-07-23, _666))