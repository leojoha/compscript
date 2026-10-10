import json

path = "wcif_data/WcTest2027/Test1_before.json"

order = [
    "Dark Blue Stage",
    "Yellow Stage",
    "White Stage",
    "Orange Stage",
    "Green Stage",
    "Red Stage",
    "Purple Stage",
    "Light Blue Stage",
    "Pink Stage",
    "Black Stage",
    "Side Room",
]

with open(path, "r", encoding="utf-8") as f:
    wcif = json.load(f)

rooms = wcif["schedule"]["venues"][0]["rooms"]

by_name = {room["name"]: room for room in rooms}

missing = [name for name in order if name not in by_name]
extra = [room["name"] for room in rooms if room["name"] not in order]

if missing or extra:
    print("Missing:", missing)
    print("Extra:", extra)
    raise SystemExit("Room names do not match expected order.")

rooms = [by_name[name] for name in order]

for i, room in enumerate(rooms, start=1):
    room["id"] = i

wcif["schedule"]["venues"][0]["rooms"] = rooms

with open("wcif_data/WcTest2027/Test1_reordered.json", "w", encoding="utf-8") as f:
    json.dump(wcif, f, ensure_ascii=False, indent=2)

print("Done: Test1_reordered.json")