# Run after _skewb-r2, _333bf-r2, _minx-r2 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_skewb-r3, 2027-07-25,
                   [Judges(), Scramblers(5, _skewb), Runners(3, _skewb), Delegate()],
                   StaffScorers(_skewb, 2027-07-25))
DoStaffAssignments(_333bf-r3, 2027-07-25,
                   [Judges(), Scramblers(5, _333bf), Runners(3, _333bf), Delegate()],
                   StaffScorers(_333bf, 2027-07-25))
DoStaffAssignments(_minx-r3, 2027-07-25,
                   [Judges(), Scramblers(5, _minx), Runners(3, _minx), Delegate()],
                   StaffScorers(_minx, 2027-07-25))