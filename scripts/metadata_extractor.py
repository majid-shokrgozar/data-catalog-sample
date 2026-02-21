import json
import requests

class MetadataExtractor:
    def __init__(self, db_connection):
        self.db_connection = db_connection

    def extract_metadata(self):
        # Implement logic to extract metadata from the database
        metadata = {}  # Replace with actual logic to fetch metadata
        return metadata

    def send_to_datahub(self, metadata, datahub_url, token):
        headers = {'Authorization': f'Bearer {token}', 'Content-Type': 'application/json'}
        try:
            response = requests.post(datahub_url, headers=headers, data=json.dumps(metadata))
            response.raise_for_status()  # Raise HTTPError for bad responses
        except requests.exceptions.RequestException as e:
            print(f"Error sending metadata to DataHub: {e}")

# Example Usage:
# db_connection = ...  # Initialize your DB connection
# metadata_extractor = MetadataExtractor(db_connection)
# metadata = metadata_extractor.extract_metadata()
# metadata_extractor.send_to_datahub(metadata, 'https://datahub.example.com/api/metadata', 'your_api_token')
