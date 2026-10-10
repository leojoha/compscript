#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_333oh-r1, 2027-07-22,
                   [Judges(), Scramblers(4, _333oh), Runners(3, _333oh), Delegate()],
                   StaffScorers(_333oh, 2027-07-22))
DoStaffAssignments(_clock-r1, 2027-07-22,
                   [Judges(), Scramblers(3, _clock), Runners(4, _clock), Delegate()],
                   StaffScorers(_clock, 2027-07-22))
DoStaffAssignments(_fto-r1, 2027-07-22,
                   [Judges(), Scramblers(4, _fto), Runners(3, _fto), Delegate()],
                   StaffScorers(_fto, 2027-07-22))
DoStaffAssignments(_pyram-r1, 2027-07-22,
                   [Judges(), Scramblers(4, _pyram), Runners(4, _pyram), Delegate()],
                   StaffScorers(_pyram, 2027-07-22))
DoStaffAssignments(_555-r1, 2027-07-22,
                   [Judges(), Scramblers(4, _555), Runners(3, _555), Delegate()],
                   StaffScorers(_555, 2027-07-22))