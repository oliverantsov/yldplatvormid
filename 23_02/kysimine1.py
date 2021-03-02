import urllib.request
import json

sisend = int(input("Sisesta augusti arv: "))

data = {
        "Inputs": {
                "input1":
                [
                    {
                            'august': sisend,   
                    }
                ],
        },
    "GlobalParameters":  {
    }
}

body = str.encode(json.dumps(data))

url = 'https://ussouthcentral.services.azureml.net/workspaces/7865dabf27694630b75cd49d58dbf618/services/f661e56aa7534b2c8d5a01d22955d956/execute?api-version=2.0&format=swagger'
api_key = '9iyMp3pdrqvNV4Dd2NWgttf+c60FTD78U74Ks+MwRnUPQ7SsHOhUVStQIioA9Ee/mka/BV+4ksulaVPZKhkbBg==' # Replace this with the API key for the web service
headers = {'Content-Type':'application/json', 'Authorization':('Bearer '+ api_key)}

req = urllib.request.Request(url, body, headers)

try:
    response = urllib.request.urlopen(req)

    result = response.read()
    print(result)
except urllib.error.HTTPError as error:
    print("The request failed with status code: " + str(error.code))

    # Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
    print(error.info())
    print(json.loads(error.read().decode("utf8", 'ignore')))

print(data["Inputs"]["input1"][0])