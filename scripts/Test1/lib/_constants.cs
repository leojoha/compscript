# Staff teams
#define DATAENTRY "staff-dataentry"
#define STAGE_STAFF "stage-staff"
#define COMMENTATOR "commentator"
#define STAGE_LEAD "stage-lead"

#define STAFF_TEAM "staff-team"
#define SIDE_ROOM_TEAM "side-room-team"

# Stages
#define DARK_BLUE "Dark Blue Stage"
#define YELLOW "Yellow Stage"
#define WHITE "White Stage"
#define ORANGE "Orange Stage"
#define GREEN "Green Stage"
#define RED "Red Stage"
#define PURPLE "Purple Stage"
#define LIGHT_BLUE "Light Blue Stage"
#define PINK "Pink Stage"
#define BLACK "Black Stage"
#define SIDE "Side Room"

Define("Stages", [DARK_BLUE, YELLOW, WHITE, ORANGE, GREEN, RED, PURPLE, LIGHT_BLUE, PINK, BLACK])
Define("SideStages", [WHITE, ORANGE, GREEN, RED, PURPLE, LIGHT_BLUE, PINK, BLACK])
Define("AHall", [DARK_BLUE, YELLOW])
Define("BCHall", [RED, GREEN, WHITE, ORANGE])
Define("DEHall", [BLACK, PINK, LIGHT_BLUE, PURPLE])
Define("IsStaff", Or(BooleanProperty(DATAENTRY),
                     BooleanProperty(STAGE_STAFF),
                     BooleanProperty(COMMENTATOR),
                     BooleanProperty(STAGE_LEAD),
                     HasRole("organizer")))

# Other roles
#define WCA_BOARD "wca-board"
#define WCA_BOOTH "wca-booth"