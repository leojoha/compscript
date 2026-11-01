#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

# Change persons and board meetings

Define("FiveblindOverlap", And((EndTime() > 2027-07-22T10:10), (StartTime() < 2027-07-22T09:00)))
Define("MultiOverlap", And((EndTime() > 2027-07-22T16:20), (StartTime() < 2027-07-22T15:00)))

AssignGroups(_333oh-r1,
             RoundOneAssignmentSets(_333oh, 2027-07-22),
             Concat(DefaultScorers(2027-07-22, _333oh),
                    [ByFilters(Or(CompetingIn(_555bf),
                                  StaffingThursdayMulti(Arg<Person>())), FiveblindOverlap(Arg<Group>()), -20),
                     ByFilters(BooleanProperty(WCA_BOARD), (GroupNumber() == 1), 10),
                     ByFilters((Arg<Person>() == 2015KUCA01), (GroupNumber() == 1), 10)]))

AssignGroups(_clock-r1,
             RoundOneAssignmentSets(_clock, 2027-07-22),
             Concat(DefaultScorers(2027-07-22, _clock),
                    [ByFilters(StaffingThursdayMulti(Arg<Person>()), (GroupNumber() < 3), 10),
                    ByFilters(Or(CompetingIn(_555bf),
                                  StaffingThursdayMulti(Arg<Person>())), FiveblindOverlap(Arg<Group>()), -20),
                     ByFilters(In(Arg<Person>(), [2005REYN01, 2007BARR01, 2011WELC01, 2004CHAN04, 2009HILD01]),
                               (GroupNumber() < 4), 10)]))

AssignGroups(_fto-r1,
             RoundOneAssignmentSets(_fto, 2027-07-22),
             DefaultScorers(2027-07-22, _fto))

AssignGroups(_pyram-r1,
             RoundOneAssignmentSets(_pyram, 2027-07-22),
             Concat(DefaultScorers(2027-07-22, _pyram),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingThursdayMulti(Arg<Person>())), 
                                  MultiOverlap(Arg<Group>()), -20)]))

AssignGroups(_555-r1,
             RoundOneAssignmentSets(_555, 2027-07-22),
             Concat(DefaultScorers(2027-07-22, _555),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingThursdayMulti(Arg<Person>())), 
                                  MultiOverlap(Arg<Group>()), -20)]))