# Run after _333oh-r1, _clock-r1 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_333oh-r2, 2027-07-22,
                   [Judges(), Scramblers(4, _333oh), Runners(3, _333oh), Delegate()],
                   StaffScorers(_333oh, 2027-07-22))
DoStaffAssignments(_clock-r2, 2027-07-22,
                   [Judges(), Scramblers(4, _clock), Runners(3, _clock), Delegate()],
                   StaffScorers(_clock, 2027-07-22))