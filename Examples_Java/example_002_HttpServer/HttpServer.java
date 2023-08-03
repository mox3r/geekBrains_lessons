package Examples_Java.example_002_HttpServer;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.charset.StandardCharsets;
import java.io.IOException;
import java.io.PrintWriter;

public class HttpServer {
    public static void main(String[] args) {
        try(ServerSocket serverSocket = new ServerSocket(8080)){
            System.out.println("Server stareted!");
            while(true){
                //wait for connect
                Socket socket = serverSocket.accept();
                System.out.println("Client connected!");

                //for connected: open streams to r & w

                try (BufferedReader input = new BufferedReader(new InputStreamReader(socket.getInputStream(), StandardCharsets.UTF_8));
                    PrintWriter output  = new PrintWriter(socket.getOutputStream())){
                
                    //wait for response

                    while (!input.ready());
                
                    //read client-sended

                    System.out.println();

                    while(input.ready()){
                    System.out.print(input.readLine());
                    }

                    //send answer

                    output.println("HTTP/1.1 200 OK");
                    output.println("Content-Type: text/html; charset=utf-8");
                    output.println();
                    output.println("<p>Гамарджоба! Greetings!</p>");
                    output.flush();

                    System.out.println("Client disconnected!");
                }
            }  
        } catch (IOException ex){
            ex.printStackTrace(); 
        }

    }
}
