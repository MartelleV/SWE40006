from flask import Flask, request, redirect, url_for
import socket

app = Flask(__name__)
# In-memory task storage
tasks = []
next_id = 1


@app.route("/")
def index():
    hostname = socket.gethostname()
    task_items = ""
    for task in tasks:
        status = "✅" if task["done"] else "⏳"
        task_items += f"""
            <li style="margin:8px 0; padding:10px; background:#f8f9fa; border-
            radius:6px;
            border-left:4px solid {'#28a745' if task['done'] else
            '#007bff'};">
            {status} <b>{task['title']}</b>
            <span style="margin-left:15px;">
            <a href="/complete/{task['id']}" style="color:#28a745">
            {'Undo' if task['done'] else 'Complete'}</a>
            &nbsp;|&nbsp;
            <a href="/delete/{task['id']}" style="color:#dc3545">Delete</a>
            </span>
            </li>
        """
    return f"""
        <html><head><title>Task Tracker</title></head>
        <body style="font-family:Arial; max-width:700px; margin:40px auto;
        padding:0 20px;">
        <h1 style="color:#1F5C99;">Task Tracker</h1>
        <p style="color:#666;">Running on container: <b>{hostname}</b></p>
        <form method="POST" action="/add" style="margin:20px 0;">
        <input name="title" placeholder="Enter a new task..."
        style="padding:10px; width:70%; border:1px solid #ccc;
        border-radius:4px;">
        <button type="submit"
        style="padding:10px 20px; background:#1F5C99; color:white;
        border:none; border-radius:4px; cursor:pointer;">
        Add Task
        </button>
        </form>
        <ul style="list-style:none; padding:0;">{task_items if task_items
            else '<p style="color:#999;">No tasks yet. Add one above!</p>'}</ul>
        </body></html>
    """


@app.route("/add", methods=["POST"])
def add_task():
    global next_id
    title = request.form.get("title", "").strip()
    if title:
        tasks.append({"id": next_id, "title": title, "done": False})
        next_id += 1
    return redirect(url_for("index"))


@app.route("/complete/<int:task_id>")
def complete_task(task_id):
    for task in tasks:
        if task["id"] == task_id:
            task["done"] = not task["done"]
            break
    return redirect(url_for("index"))


@app.route("/delete/<int:task_id>")
def delete_task(task_id):
    global tasks
    tasks = [t for t in tasks if t["id"] != task_id]
    return redirect(url_for("index"))


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=80)
