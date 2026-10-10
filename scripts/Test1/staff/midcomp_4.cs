# Run after _222-r1, _444-r1, _sq1-r1, _666-r1 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_222-r2, 2027-07-24,
                   [Judges(), Scramblers(5, _222), Runners(3, _222), Delegate()],
                   StaffScorers(_222, 2027-07-24))
DoStaffAssignments(_444-r2, 2027-07-24,
                   [Judges(), Scramblers(4, _444), Runners(4, _444), Delegate()],
                   StaffScorers(_444, 2027-07-24))
DoStaffAssignments(_sq1-r2, 2027-07-24,
                   [Judges(), Scramblers(5, _sq1), Runners(3, _sq1), Delegate()],
                   StaffScorers(_sq1, 2027-07-24))
DoStaffAssignments(_666-r2, 2027-07-24,
                   [Judges(), Scramblers(5, _666), Runners(3, _666), Delegate()],
                   StaffScorers(_666, 2027-07-24))