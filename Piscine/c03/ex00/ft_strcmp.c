/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strcmp.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/10/29 20:54:56 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/03 15:07:40 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
#include <stdio.h>
#include <string.h>

int		ft_strcmp(char *s1, char *s2)
{
	while (*s1 != '\0' && (*s1 == *s2))
	{
		s1++;
		s2++;
	}
	return (*(unsigned char*)s1 - *(unsigned char*)s2);
}
int main(void)
{
	char s1[] = "ola";
	char s2[] = "ola";
	char s3[] = "olaa";
	printf("%d \n", strcmp(s1,s3));
	printf("--------------");
	printf("%d \n", ft_strcmp(s1, s3));
}
