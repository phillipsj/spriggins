# Spriggins: Making Elastic Beanstalk Packaging Easier

Spriggins started as an idea to allow a single yaml file to define the package that needs to be created for deployment to Elastic Beanstalk. While you can use the Elastic Beanstalk CLI or do this by hand, I thought it would be nice to allow a single file to generate the structure for you and to create a deployment package that can be used as an artifact. 

## Why is it called Spriggins

Well I was looking around and thinking about names that would be beanstalk related. A few had already been taken, however from Wikipedia and additional resources, it seems the original name for *Jack and the beanstalk* was *The Story of Jack Spriggins and the Enchanted Bean*. So I decided to use Spriggins for the name.

## Technology

This application is built using .NET Core and will be compiled using CoreRT which will allow the app to be compiled native to all the platforms.
