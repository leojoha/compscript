# Run after _skewb-r1, _333-r1, _777-r1, _333bf-r1 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_skewb-r2, 2027-07-25,
                   [Judges(), Scramblers(5, _skewb), Runners(3, _skewb), Delegate()],
                   StaffScorers(_skewb, 2027-07-25))
DoStaffAssignments(_333-r2, 2027-07-25,
                   [Judges(), Scramblers(4, _333), Runners(4, _333), Delegate()],
                   StaffScorers(_333, 2027-07-25))
DoStaffAssignments(_777-r2, 2027-07-25,
                   [Judges(), Scramblers(5, _777), Runners(3, _777), Delegate()],
                   StaffScorers(_777, 2027-07-25))
DoStaffAssignments(_333bf-r2, 2027-07-25,
                   [Judges(), Scramblers(5, _333bf), Runners(3, _333bf), Delegate()],
                   StaffScorers(_333bf, 2027-07-25))