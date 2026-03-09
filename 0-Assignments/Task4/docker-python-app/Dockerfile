# Use official Python 3.11 slim runtime as base image
FROM python:3.11-slim

# Set the working directory inside the container
WORKDIR /app

# Copy requirements first for Docker layer caching optimisation
COPY requirements.txt .

# Install Python dependencies
RUN pip install --no-cache-dir -r requirements.txt

# Copy the rest of the application code
COPY . .

# Expose port 80 to the host
EXPOSE 80

# Run the Flask application when the container starts
CMD ["python", "app.py"]