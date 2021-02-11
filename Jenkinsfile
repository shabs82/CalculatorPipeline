pipeline{
	agent any
  triggers{
  cron("H/3 * * *")
  }
	stages{
		stage("Build"){
			steps{
			sh "dotnet build CalculatorPipeline.csproj"
			}
     }
      stage("Test"){
      steps{
      sh "dotnet test CalculatorPipeline.csproj"
		}
	}
}
