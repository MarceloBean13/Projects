/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strcapitalize.c                                 :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/10/29 14:15:01 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/01 17:27:55 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

char	*ft_strcapitalize(char *str)
{
	int c;

	c = 0;
	while (str[c] != '\0')
	{
		if (c == 0 && str[c] >= 'a' && str[c] <= 'z')
			str[c] = str[c] - 32;
		if ((str[c - 1] >= 'A' && str[c - 1] <= 'Z'
					&& str[c] >= 'A' && str[c] <= 'Z') ||
				(str[c - 1] >= 'a' && str[c - 1] <= 'z' &&
				str[c] >= 'A' && str[c] <= 'Z'))
			str[c] = str[c] + 32;
		if (str[c - 1] >= '0' && str[c - 1] <= '9'
				&& (str[c] >= 'A' && str[c] <= 'Z'))
			str[c] = str[c] + 32;
		if ((str[c - 1] < '0' && str[c] >= 'a' && str[c] <= 'z') ||
				(str[c - 1] > '9' && str[c - 1] < 'A' &&
				str[c] >= 'a' && str[c] <= 'z') ||
				(str[c - 1] > 'Z' && str[c - 1] < 'a' &&
				str[c] >= 'a' && str[c] <= 'z') ||
				(str[c - 1] > 'z' && str[c] >= 'a' && str[c] <= 'z'))
			str[c] = str[c] - 32;
		c++;
	}
	return (str);
}
