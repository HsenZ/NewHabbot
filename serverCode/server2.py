import socket
import ollama
import os


template = 'Dont use markup language.The answer should be in one paragraph.Dont be talkative/ 2 sentences at most.Only print the answer.'
# Create a TCP/IP socket
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Bind the socket to the address and port
server_address = ('192.168.0.109', 8888)
print('Starting up on {} port {}'.format(*server_address))

# Wait for a connection
server_socket.bind(server_address)

# Listen for incoming connections
server_socket.listen(2)
while True:
    print('listning on 192.168.0.109| 8888')
    connection, client_address = server_socket.accept()
    print('Connection from', client_address)
    data = connection.recv(1024)
    if data:
        print(data.decode('utf-8'))
        response = ollama.generate(model='gemma:2b', prompt=template+data.decode('utf-8'))
        print(response['response'])
        response = response['response'].encode('utf-8')
        connection.sendall(response)
    else:
        print("failed")
        connection.sendall('failed'.encode('utf-8'))

    connection.close()      