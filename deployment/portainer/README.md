# Portainer Stack

This directory contains a simple Docker Compose file that can be used to deploy Jellyfin through Portainer.

## Usage

1. In Portainer, navigate to **Stacks** and select **Add stack**.
2. Copy the contents of `docker-compose.yml` into the web editor or upload the file.
3. Adjust the volume paths if needed to point to your media and configuration directories.
4. Deploy the stack.

The container runs in host network mode and maps `./config`, `./cache` and `./media` directories on the host for persistent storage. Adjust the directories to suit your environment.
