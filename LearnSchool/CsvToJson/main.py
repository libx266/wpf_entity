import os, csv, json


for file in os.listdir("./csv"):
    data = []
    with open(f"./csv/{file}", 'r', encoding='utf-8') as f:
        reader = csv.DictReader(f, delimiter=',');
        for r in reader:
            data.append(r)

    with open(f"./{file}.json", 'w', encoding='utf-8') as j:
        j.write(json.dumps(data, indent=2))


