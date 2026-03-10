import random
import mysql.connector

db = mysql.connector.connect(
    host="localhost",
    user="rio",
    password="4FiveF0ur6Bee",
    database="cockfight_db"
)

cursor = db.cursor()

cursor.execute("SELECT match_id, rooster_a, rooster_b FROM matches WHERE status='closed'")
matches = cursor.fetchall()

for match in matches:
    match_id, rooster_a, rooster_b = match
    winner = random.choice([rooster_a, rooster_b])
    cursor.execute("UPDATE matches SET winner=%s, status='finished' WHERE match_id=%s", (winner, match_id))

db.commit()
cursor.close()