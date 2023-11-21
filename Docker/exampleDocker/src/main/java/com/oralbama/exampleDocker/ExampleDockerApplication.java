package com.oralbama.exampleDocker;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@SpringBootApplication
public class ExampleDockerApplication {
	@GetMapping("saludo")
	public String getMessage(){
		return "Hola mundo";
	}

	public static void main(String[] args) {
		SpringApplication.run(ExampleDockerApplication.class, args);
	}

}
