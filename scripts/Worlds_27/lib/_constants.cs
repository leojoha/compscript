# Staff teams
#define DATAENTRY "staff-dataentry"
#define STAGE_STAFF "stage-staff"
#define LIVE_STREAM "live-stream"
#define STAGE_LEAD "stage-lead"
#define SIDE_ROOM "side-room"

#define STAFF_TEAM "staff-team"
#define SIDE_ROOM_TEAM "side-room-team"

#define STREAM_ROOM "stream-room"

# Stages
#define BLUE "Blue Stage"
#define YELLOW "Yellow Stage"
#define RED "Red Stage"
#define GREEN "Green Stage"
#define ORANGE "Orange Stage"
#define WHITE "White Stage"
#define PURPLE "Purple Stage"
#define BROWN "Brown Stage"
#define PINK "Pink Stage"
#define BLACK "Black Stage"
#define SIDE "Side Room"

Define("Stages", [BLUE, YELLOW, RED, GREEN, ORANGE, WHITE, PURPLE, BROWN, PINK, BLACK])
Define("SideStages", [RED, GREEN, ORANGE, WHITE, PURPLE, BROWN, PINK, BLACK])
Define("HallA", [BLUE, YELLOW])
Define("HallBC", [RED, GREEN, ORANGE, WHITE])
Define("HallDE", [PURPLE, BROWN, PINK, BLACK])
Define("IsStaff", Or(BooleanProperty(DATAENTRY),
                     BooleanProperty(STAGE_STAFF),
                     BooleanProperty(LIVE_STREAM),
                     BooleanProperty(SIDE_ROOM),
                     BooleanProperty(STAGE_LEAD),
                     HasRole("organizer")))

# Other roles
#define WCA_BOARD "wca-board"
#define WCA_BOOTH "wca-booth"