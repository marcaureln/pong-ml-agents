# hello-unity

**Environment:**

- Unity version: Unity 22.3.10f1
- OS: Linux Mint 21.2
- Python version: 3.10.12
- ML-Agents version: 0.30.0

## Getting Started

Install Unity

### ML-Agents Toolkit

1. Install Python
2. Install the `com.unity.ml-agents` Unity package
3. Install the `mlagents` Python package:

```bash
# Create Python virtual environment
python3 -m venv venv
# Activate environment
source venv/bin/activation
# Install mlagents Python package
# I had some issue installing this version of the package, it should be resolved in the future.
# Meanwhile, this link can help: https://github.com/Unity-Technologies/ml-agents/issues/5826  
pip3 install mlagents==0.30.0 
```

Detailed instructions: https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Installation.md
