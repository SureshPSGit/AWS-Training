node {
    def built_img = ''
    stage('Checkout Git Repo') {
      git branch: 'master', url: 'https://github.com/SureshPSGit/AWS-Training.git'
    }
    stage('Build Docker image') {
      
      sh(script: "docker build -t ${aws_training:latest -f src/AWS-Training/Dockerfile .", returnStdout: true)
     
    }
    stage('Unit Tests') {
      sh 'echo test'
    }
    stage('Browser Tests'){
        parallel(
            "Edge":{sh 'echo test'},
            "Firefox":{sh 'echo test'},
            "Chrome":{sh 'echo test'}
            )
    }
    stage('Deploy into k8s') {
      sh 'Deploy'
    }
}
