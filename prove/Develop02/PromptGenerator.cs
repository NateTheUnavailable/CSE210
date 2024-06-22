using System;

class PromptGenerator
{
    public string GeneratePrompt()
    {
        string[] prompts = { "Write about a happy moment today.", "What are you grateful for today?", "Describe a challenge you overcame recently." };
        Random random = new Random();
        int index = random.Next(prompts.Length);

        return prompts[index];
    }
}
