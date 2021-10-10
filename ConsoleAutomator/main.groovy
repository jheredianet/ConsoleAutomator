import hudson.model.*

def consoleautomator(Map parameters) {
    stage ('Git Checkout') {
        node {
          git branch: 'master', credentialsId: 'GitLabHTTP', 
          url: 'https://gitlab.com/juanheredia/consoleautomator.git'
        }
    }
    stage ('Build .NET') {
        node {
            sh 'dotnet build'
        }
    }
    stage ('Run .NET') {
        node {
            sh 'ConsoleAutomator/bin/Debug/net5.0/ConsoleAutomator'
        }
    }
}

return this