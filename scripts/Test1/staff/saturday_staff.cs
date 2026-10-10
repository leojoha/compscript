#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_skewb-r1, 2027-07-24,
                   [Judges(), Scramblers(4, _skewb), Runners(3, _skewb), Delegate()],
                   StaffScorers(_skewb, 2027-07-24))
DoStaffAssignments(_333-r1, 2027-07-24,
                   [Judges(), Scramblers(3, _333), Runners(4, _333), Delegate()],
                   StaffScorers(_333, 2027-07-24))
DoStaffAssignments(_777-r1, 2027-07-24,
                   [Judges(), Scramblers(4, _777), Runners(3, _777), Delegate()],
                   StaffScorers(_777, 2027-07-24))
DoStaffAssignments(_333bf-r1, 2027-07-24,
                   [Judges(), Scramblers(4, _333bf), Runners(4, _333bf), Delegate()],
                   StaffScorers(_333bf, 2027-07-24))