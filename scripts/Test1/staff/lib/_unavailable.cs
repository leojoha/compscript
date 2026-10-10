#include "../../lib/_constants.cs"
#include "../../lib/_long_room_staff.cs"

Define("CompetingTimes",
       Map(Filter(AssignedGroups({1, Person}), {2, Boolean(Group)}), StartTime()))

Define("MainStageCompetingTimes",
       Map(Filter(AssignedGroups({1, Person}),
                  And({2, Boolean(Group)},
                      Not(In(Round(), [_333fm-r1, _333mbf-r1, _555bf-r1])))),
           StartTime()))

Define("Unavailable",
       Concat(
         Switch(
           {1, Person},
           [
             Tuple(2015BURG02, [UnavailableBetween(2024-07-21T00:00, 2024-07-21T11:00)]),  # Brock Burgi
             Tuple(2015PADG01, [UnavailableBetween(2024-07-19T20:53, 2024-07-20T20:52)])],  # Dalton Padgett
           defaultValue=[]),
         If(StaffingThursdayMulti(Arg<Person>()),
            [UnavailableBetween(2024-07-18T14:00, 2024-07-18T14:15), # Change hand-in time
             UnavailableBetween(2027-07-22T15:00, 2027-07-22T16:20)], []),
         If(StaffingFridayFMC(Arg<Person>()),
            [UnavailableBetween(2027-07-23T09:05, 2027-07-23T10:20),
             UnavailableBetween(2027-07-23T12:50, 2027-07-23T14:05),
             UnavailableBetween(2027-07-23T14:05, 2027-07-23T15:20)], []),
         If(StaffingSaturdayMulti(Arg<Person>()),
            [UnavailableBetween(2024-07-18T09:30, 2024-07-18T12:15), # Change hand-in time
             UnavailableBetween(2027-07-24T14:20, 2027-07-24T15:40)], []),
         If(StaffingThursday5BLD(Arg<Person>()),
            [UnavailableBetween(2027-07-22T09:00, 2027-07-22T10:15)], []),
         If(StaffingSunday4BLD(Arg<Person>()), 
            [UnavailableBetween(2027-07-25T09:00, 2027-07-25T09:45)], []),
         If(CompetingIn(_333mbf),
            [UnavailableBetween(2027-07-22T15:00, 2027-07-22T16:20),
             UnavailableBetween(2027-07-24T14:20, 2027-07-24T15:40)], []),
        If(CompetingIn(_333fm),
            [UnavailableBetween(2027-07-23T09:05, 2027-07-23T10:20),
             UnavailableBetween(2027-07-23T12:50, 2027-07-23T14:05),
             UnavailableBetween(2027-07-23T14:05, 2027-07-23T15:20)], []),
        If(CompetingIn(_444bf),
            [UnavailableBetween(2027-07-25T09:00, 2027-07-25T09:45)], []),
         If(CompetingIn(_555bf),
            [UnavailableBetween(2027-07-22T09:00, 2027-07-22T10:15)], [])))