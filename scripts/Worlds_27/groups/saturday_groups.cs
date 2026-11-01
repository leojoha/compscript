#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

# Change persons and board meetings

Define("MultiOverlap", And((EndTime() > 2027-07-24T15:40), (StartTime() < 2027-07-24T14:20)))

AssignGroups(_skewb-r1,
             RoundOneAssignmentSets(_skewb, 2027-07-24),
             DefaultScorers(2027-07-24, _skewb))

AssignGroups(_333-r1,
             RoundOneAssignmentSets(_333, 2027-07-24),
             Concat(DefaultScorers(2027-07-24, _333),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingSaturdayMulti(Arg<Person>())), MultiOverlap(Arg<Group>()), -20)]))

AssignGroups(_777-r1,
             RoundOneAssignmentSets(_777, 2027-07-24),
             DefaultScorers(2027-07-24, _777))

AssignGroups(_333bf-r1,
             RoundOneAssignmentSets(_333bf, 2027-07-24),
             DefaultScorers(2027-07-24, _333bf))