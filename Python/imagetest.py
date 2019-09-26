import requests
import json

SUBSCRIPTION_KEY = "d7546477e465451abb7e2f50379bda2e"

vision_service_address = "https://northeurope.api.cognitive.microsoft.com/vision/v2.0/"
address = vision_service_address + "analyze"

parameters  = {'visualFeatures':'Adult, Brands, Categories, Faces, Objects, Description,Color','language':'en'}

#image_path = "C:/Temp/bring.jpg"
#image_path = "C:\Temp\hki_Komulainen_Teemu_1060.jpg"
image_path = "C:/Temp/download.jpg"
image_data = open(image_path, "rb").read()

headers    = {'Content-Type': 'application/octet-stream','Ocp-Apim-Subscription-Key': SUBSCRIPTION_KEY}

response = requests.post(address, headers=headers, params=parameters, data=image_data)

response.raise_for_status()

# Display the JSON results returned
results = response.json()
print(json.dumps(results))