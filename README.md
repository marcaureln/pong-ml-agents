# pong-ml-agents

[ML-Agents tutorial by Code Monkey](https://www.youtube.com/watch?v=zPFU30tbyKs)

## Getting Started

### Setting Up Your Development Environment

1. Install [Unity](https://unity.com/)
2. Install [Anaconda](https://www.anaconda.com/)
3. Clone this repo

### Setting Up ML-Agents Toolkit

1. Install the `com.unity.ml-agents` Unity package
2. Install the `mlagents` Python package, you can follow this:

```bash
# Create a Conda environment with Python 3.8
conda create -n ml-agents python=3.8
# Activate environment
conda activate ml-agents
# Install mlagents Python package  
pip3 install mlagents==0.30.0
pip3 install protobuf==3.20.3 # Troubleshooting
# Don't hesitate to install any missing package
```

You can find detailed installation instructions [here](https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Installation.md).
