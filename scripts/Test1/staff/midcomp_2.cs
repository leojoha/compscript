# Run after _fto-r1, _pyram-r1, _555-r1, _333oh-r2, _clock-r2 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_fto-r2, 2027-07-23,
                   [Judges(), Scramblers(5, _fto), Runners(3, _fto), Delegate()],
                   StaffScorers(_fto, 2027-07-23))
DoStaffAssignments(_pyram-r2, 2027-07-23,
                   [Judges(), Scramblers(4, _pyram), Runners(4, _pyram), Delegate()],
                   StaffScorers(_pyram, 2027-07-23))
DoStaffAssignments(_555-r2, 2027-07-23,
                   [Judges(), Scramblers(5, _555), Runners(3, _555), Delegate()],
                   StaffScorers(_555, 2027-07-23))
DoStaffAssignments(_333oh-r3, 2027-07-23,
                   [Judges(), Scramblers(5, _333oh), Runners(3, _333oh), Delegate()],
                   StaffScorers(_333oh, 2027-07-23))
DoStaffAssignments(_clock-r3, 2027-07-23,
                   [Judges(), Scramblers(5, _clock), Runners(3, _clock), Delegate()],
                   StaffScorers(_clock, 2027-07-23))