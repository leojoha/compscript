#include "../lib/_constants.cs"
#include "../lib/_side_room_staff.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

AssignStaff(
    _333fm-r1, true, Persons(StaffingFridayFMC(Arg<Person>())),
    [Job("judge", 4)],
    [
      GroupScorer(And((Date() == 2027-07-23), StaffingFridayFMC(Arg<Person>())), 1)
    ], unavailable=[])

AssignStaff(
    _333mbf-r1, true, Persons(Or(StaffingThursdayMulti(Arg<Person>()),
                                 StaffingSaturdayMulti(Arg<Person>()))),
    [Job("judge", 8)],
    [
      GroupScorer(And((Date() == 2027-07-22), StaffingThursdayMulti(Arg<Person>())), 1),
      GroupScorer(And((Date() == 2027-07-24), StaffingSaturdayMulti(Arg<Person>())), 1)
    ])

AssignStaff(
    _555bf-r1, true, Persons(StaffingThursday5BLD(Arg<Person>())),
    [Job("judge", 13), Job("scrambler", 3)],
    StaffScorers(_555bf, 2027-07-22))

AssignStaff(
    _444bf-r1, true, Persons(StaffingSunday4BLD(Arg<Person>())),
    [Job("judge", 13), Job("scrambler", 3)],
    StaffScorers(_444bf, 2027-07-25))