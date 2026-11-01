#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

# Change persons and board meetings

Define("FourblindOverlap", And((EndTime() > 2027-07-25T09:45), (StartTime() < 2027-07-25T09:00)))

AssignGroups(_minx-r1,
             RoundOneAssignmentSets(_minx, 2027-07-25),
             Concat(DefaultScorers(2027-07-25, _minx),
                    [ByFilters(Or(CompetingIn(_444bf),
                                  StaffingSunday4BLD(Arg<Person>())), FourblindOverlap(Arg<Group>()), -20)]))