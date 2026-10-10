# Run after _333-r2 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_333-r3, 2027-07-25,
                   [Judges(), Scramblers(5, _333), Runners(3, _333), Delegate()],
                   StaffScorers(_333, 2027-07-25))