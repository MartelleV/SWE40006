from flask import Flask
import socket

app = Flask(__name__)


@app.route("/")
def hello():
    hostname = socket.gethostname()
    return f"""
        <html><body style="font-family:Arial; padding:40px;">
        <h1>Hello from Docker!</h1>
        <p><b>Hostname:</b> {hostname}</p>
        <p><b>Python Flask app</b> running inside a Docker container.</p>
        </body></html>
    """


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=80)
