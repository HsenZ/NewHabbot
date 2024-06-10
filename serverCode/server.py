import socket
import ollama
import os

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

    #data = connection.recv(1)
    #is_image = int.from_bytes(data,byteorder='little')
    is_image=0
    if is_image==1:
        with open("sami.jpg","wb") as image:
            data = connection.recv(4)
            if len(data) == 4:
                lenght = int.from_bytes(data,byteorder='little')
            image_data = b''
            while len(image_data)< lenght:
                data = connection.recv(lenght-len(image_data))
                if not data:
                    connection.close()
                image_data+= data

            #image.write(image_data)
            #connection.sendall("3rase ya dasme".encode('utf-8'))

    elif is_image==0:
    # Receive the data from the client
        data = connection.recv(1024)

        if data:
            text = data.decode('utf-8')
            if os.path.isfile("sami.jpg"):
                '''
                image = open("sami.jpg",'rb')
                response = ollama.chat(
                    model='llava',
                    messages=[
                        {
                            'role':'user',
                            'content':data.decode('utf-8'),
                            'images':[image.read()]
                        }
                    ]
                )
                response = response['message']['content'].encode('utf-8')
                '''
            else:
                print(data.decode('utf-8'))
                response = ollama.generate(model='gemma:2b', prompt=data.decode('utf-8'))
                print(response['response'])
                response = response['response'].encode('utf-8')
            connection.sendall(response)
            #break
        else:
            print("failed")
            connection.sendall('failed'.encode('utf-8'))

    connection.close()


       
        