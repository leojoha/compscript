# Run after _minx-r1 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_minx-r2, 2027-07-25,
                   [Judges(), Scramblers(5, _minx), Runners(3, _minx), Delegate()],
                   StaffScorers(_minx, 2027-07-25))