import os
import shutil
from werkzeug.datastructures import file_storage

dic_files = {}
local_directory = os.getcwd()

current_working_directory = os.path.join(local_directory,"TEMPLATE_MANIPULATION_TEST")
save_project_directory = os.path.join(local_directory,"NEW_TEMPLATE3")

# create copy of the project to save in another location 
os.makedirs(save_project_directory, exist_ok=True)
if os.path.exists(save_project_directory):
    shutil.rmtree(save_project_directory)


new_path = shutil.copytree(current_working_directory,save_project_directory)

def get_value_of_key(search_key):
    #later on, might need to fix the extension for other types
    search_key = search_key.replace(".cs","")
    from naming_conventions import naming_conventions
    for category, items in  naming_conventions.items():
        for key, value in items.items():
            if search_key == key:
             return value+".cs"
    print("\n\n\nWe did not found for " + search_key+"\n")     
    print(naming_conventions.items())
    print("\n\n")
    return "VALUE_OF_KEY_NOT_FOUND"

def update_keys_of_file(file_path):
    f = open(file_path, 'r')
    file_txt = f.read()

    from naming_conventions import naming_conventions

    for category, items in  naming_conventions.items():
        for key, value in items.items():
            file_txt = file_txt.replace(key, value)
    return file_txt

def write_in_file(file_path,text):
    file1 = open(file_path, 'w')
    file1.write(text)
    file1.close()
    # print("Written at "+ os.path.basename(file_path))
        
def add_new_service(service_name):
    print("addservice()")
    # dic_files[]
    # previous_path = file_path
    # new_path = os.path.join(os.path.dirname(file_path), new_file_name)
    # os.rename(previous_path, new_path)
    # file_path = os.path.join(os.path.dirname(file_path), new_file_name)
    
        
def add_file_and_text_to_dictionary(file_path,file_txt):
    dic_files[file_path] = "ds"
    
def file_to_string(file_path):
    f = open(file_path, 'r')
    file_txt = f.read()
    add_file_and_text_to_dictionary(file_path, file_txt)
    
    
res = []

# iterate in directory 
for root, dirs, files in os.walk(save_project_directory):
    for file in files:
        file_path = os.path.join(root, file)
        if os.path.isfile(file_path):
            if file_path.endswith(".cs"):
                cs_file_name = os.path.basename(file_path)                
                res.append(file_path)
                new_text = update_keys_of_file(file_path)
                if(cs_file_name.__contains__("TEMPLATE")):
                    print(file_to_string(file_path))
                    #removing the extension 
                    # new_file_name = get_value_of_key(cs_file_name)
                    # previous_path = file_path
                    # new_path = os.path.join(os.path.dirname(file_path), new_file_name)
                    # os.rename(previous_path, new_path)
                    # file_path = os.path.join(os.path.dirname(file_path), new_file_name)
                    
                # write_in_file(file_path,new_text)
                
                
for key,value in dic_files.items():
    print(key," - ")
    
    
add_new_service("hotelRoom")
    