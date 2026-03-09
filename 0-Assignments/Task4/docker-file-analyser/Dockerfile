# Python 3.11 slim — no web server, pure CLI application
FROM python:3.11-slim

# Set working directory
WORKDIR /app

# Copy application files
COPY analyser.py .
COPY data.txt .

# No EXPOSE directive because this is not a web application
# Run the analyser directly on the bundled data file
CMD ["python", "analyser.py", "data.txt"]