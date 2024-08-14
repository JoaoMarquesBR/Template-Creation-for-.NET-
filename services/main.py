import os
import shutil

current_working_directory = "C:\\Users\\MrPro\\source\\VS_RESPOS\\python\\Create Templates Dotnet\\TEMPLATE_MANIPULATION_TEST"
save_project_directory = "C:\\Users\\MrPro\\source\\VS_RESPOS\\python\\Create Templates Dotnet\\NEW_TEMPLATE3"

# create copy of the project to save in another location 
os.makedirs(save_project_directory, exist_ok=True)
if os.path.exists(save_project_directory):
    shutil.rmtree(save_project_directory)
    print("deleting directory")

new_path = shutil.copytree(current_working_directory,save_project_directory)
print("creating directory")
print(new_path)

def update_keys_of_file(file_path):
    f = open(file_path, 'r')
    file_txt = f.read()

    from naming_conventions import naming_conventions

    for category, items in  naming_conventions.items():
        # print(f"{category}:")
        for key, value in items.items():
            # print(f"Key = {key}   :   Valor = {value}")
            file_txt = file_txt.replace(key, value)
    return file_txt

def write_in_file(file_path,text):
    file1 = open(file_path, 'w')
    file1.write(text)
    file1.close()
    print("Saving at "+ file_path)
    print()
    
res = []

# iterate in directory 
for root, dirs, files in os.walk(save_project_directory):
    for file in files:
        file_path = os.path.join(root, file)
        if os.path.isfile(file_path):
            if file_path.endswith(".cs"):
                res.append(file_path)
                new_text = update_keys_of_file(file_path)
                write_in_file(file_path,new_text)